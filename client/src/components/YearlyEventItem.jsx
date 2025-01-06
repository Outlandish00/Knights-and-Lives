import "./YearlyEventItem.css"

export const YearlyEventItem = ({event, currentYear}) => {
    return(<div className="yearly-event-item"><div className="yearly-event-year">{event.year}</div><div className="yearly-event">{event.name}</div></div>)
}