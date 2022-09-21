import API_URL from "../env";

const FeedService = {
    fetchFeeds: async function() {
        const response = await fetch(`${API_URL}/Feeds`);
        return response.json();
    },
    fetchFeed: async function(id) {
        const response = await fetch(`${API_URL}/Feeds/${id}`);
        return response.json();
    }
};

export default FeedService;
