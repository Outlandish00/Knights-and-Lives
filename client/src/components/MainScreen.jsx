import { useEffect, useState } from "react"
import { MenuBar } from "./MenuBar"
import { YearlyEventItem } from "./YearlyEventItem"
import"./MainScreen.css"

export const MainScreen = ({allYearlyEvents}) => {
    const [eventList, setEventList] = useState([])
    const [currentYear, setCurrentYear] = useState(0)
    useEffect(() => {
        setCurrentYear(1200)
    }, [])
   // Add new event to the event list and increment the year
    const addNewEventToScreen = (event) => {
        const eventWithYear = {
            ...event,
            year: currentYear, // Attach the current year to the event
        }
        setEventList((previousList) => [...previousList, eventWithYear])
        setCurrentYear((prevYear) => prevYear + 1) // Increment the year for the next event
    }
    return (<div className="screen-inner-container"><MenuBar currentYear={currentYear} setCurrentYear={setCurrentYear} allYearlyEvents={allYearlyEvents} addNewEvent={addNewEventToScreen}/><div className="yearly-event-screen"><ul className="event-list">{eventList.map((event) => (
        <li><YearlyEventItem currentYear={currentYear} event={event}/></li>
    ))}</ul></div></div>)
}