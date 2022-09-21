import "./Entry.css"

function Entry({entry}) {
    return (
        <article>
            <div>
                <h2>{entry.title}</h2>
                <div className="Entry-header flex-center">
                    {entry.author.name}
                    <div className="Entry-published">{entry.published}</div>
                </div>
            </div>
            <div className="Entry-content" dangerouslySetInnerHTML={{__html: entry.content}}/>
        </article>
    );
}

export default Entry;
