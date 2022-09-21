import "./Feed.css";
import Entry from "./Entry";
import { useState, useEffect } from "react";
import FeedService from "../services/FeedService";

export default function Feed(props) {
    const [feed, setFeed] = useState(null);

    async function fetchFeed(id) {
        setFeed(await FeedService.fetchFeed(id));
    }

    useEffect(() => {
        fetchFeed(props.id);
    }, [props.id]);

    if (!feed) {
        return "Loading...";
    }

    return (
        <div>
            <div className="flex-center">
                <img src={feed.icon} alt="Feed icon" />
                <h1 className="Feed-title">{feed.title}</h1>
            </div>
            <div className="xs-font">Updated: {feed.updated}</div>
            <ul>
                {feed.entries.map((entry) => 
                    <li key={entry.id}>
                        <Entry entry={entry} />
                    </li>
                )}
            </ul>
        </div>
    );
}
