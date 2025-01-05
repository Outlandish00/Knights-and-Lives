import { useState } from "react"
import { MenuBar } from "./MenuBar"
import { YearlyEventItem } from "./YearlyEventItem"
import"./MainScreen.css"

export const MainScreen = ({allYearlyEvents}) => {
    const [eventList, setEventList] = useState([])
    const addNewEventToScreen = (event) => {
        setEventList((previousList) => [...previousList,event])
    }
    return (<div className="screen-inner-container"><MenuBar allYearlyEvents={allYearlyEvents} addNewEvent={addNewEventToScreen}/><div className="yearly-event-screen"><ul className="event-list">{eventList.map((event) => (
        <li><YearlyEventItem event={event}/></li>
    ))}</ul></div></div>)
}