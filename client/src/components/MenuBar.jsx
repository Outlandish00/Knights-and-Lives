import { useEffect, useState } from "react";
import { getARandomNumberInRange } from "../scripts/scripts";
import "./MenuBar.css"
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faComment, faEllipsis, faHouse, faPerson } from "@fortawesome/free-solid-svg-icons";
import { getRandomMajorEvent } from "../scripts/apiManager";

export const MenuBar = ({allYearlyEvents, addNewEvent, currentYear , setCurrentYear}) => {
    const [usedEvents, setUsedEvents] = useState([])
    const [randomMajorEvent, setRandomMajorEvent] = useState({})
    const getRandomNotUsedYearlyEvent = () => {
        const randomIndex = getARandomNumberInRange(0, allYearlyEvents.length)
        let foundRandomEvent = allYearlyEvents[randomIndex]
        if (!usedEvents.some(event => event === foundRandomEvent && allYearlyEvents.length))
        {
            console.log(foundRandomEvent)
            setUsedEvents((events) => [...events,foundRandomEvent])
            addNewEvent(foundRandomEvent);
            setCurrentYear(currentYear + 1)
        }
        else {return getRandomNotUsedYearlyEvent();}
    }

    const randomMajorEventHandler = () => {
        const randomNumber = Math.random();
        if (randomNumber < 0.3 )
        {
            getRandomMajorEvent().then((data) => setRandomMajorEvent(data))
        }
    }


    return(<><div className="menu-bar-container"><div className="menu-item"><FontAwesomeIcon icon={faPerson} className="person-icon"/></div><div className="menu-item"><FontAwesomeIcon icon={faComment} className="social-icon"/></div><button id="menu-button"onClick={() => {getRandomNotUsedYearlyEvent (); randomMajorEventHandler();}}>Advance Year</button><div className="menu-item"><FontAwesomeIcon icon={faHouse} className="house"/></div><div className="menu-item"><FontAwesomeIcon icon={faEllipsis} className = "dots" /></div></div><div className="menu-spacer"></div></>)
}