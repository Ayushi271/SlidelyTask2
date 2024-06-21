import { Router, Request, Response } from 'express';
import fs from 'fs';

interface Submission {
    name: string;
    email: string;
    phone: string;
    github_link: string;
    stopwatch_time: number;
}

const router = Router();
const dbPath = './src/db.json';

router.get('/ping', (req: Request, res: Response) => {
    res.send(true);
});

router.post('/submit', (req: Request, res: Response) => {
    const submission: Submission = req.body;

    // Read the existing data
    const data = fs.readFileSync(dbPath, 'utf-8');
    const submissions: Submission[] = JSON.parse(data || '[]');

    // Add the new submission
    submissions.push(submission);

    // Write the updated data back to the file
    fs.writeFileSync(dbPath, JSON.stringify(submissions, null, 2));

    res.sendStatus(200);
});

router.get('/read', (req: Request, res: Response) => {
    const index = parseInt(req.query.index as string);

    // Read the existing data
    const data = fs.readFileSync(dbPath, 'utf-8');
    const submissions: Submission[] = JSON.parse(data || '[]');

    if (index >= 0 && index < submissions.length) {
        res.json(submissions[index]);
    } else {
        res.sendStatus(404);
    }
});

export { router };
