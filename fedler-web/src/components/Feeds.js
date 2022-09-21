import { useEffect, useState } from "react";
import { Link } from "react-router-dom";
import FeedService from "../services/FeedService";

export default function Feeds() {
    const [feeds, setFeeds] = useState(null);

    async function fetchFeeds() {
        setFeeds(await FeedService.fetchFeeds());
    }

    useEffect(() => {
        fetchFeeds();
    }, []);

    if (!feeds) {
        return "Loading...";
    }

    return (
        <div>
            <ul>
                {feeds.map(feed =>
                    <li key={feed.id}>
                        <Link to={`${feed.id}`}>{feed.title}</Link>
                    </li>
                )}
            </ul>
        </div>
    );
}
