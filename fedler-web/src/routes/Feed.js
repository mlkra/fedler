import { useParams } from "react-router-dom";
import FeedComponent from "../components/Feed"

export default function Feed() {
    const { feedId } = useParams();
    return <FeedComponent id={feedId} />;
}
