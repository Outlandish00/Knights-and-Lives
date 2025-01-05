import { useEffect, useState } from "react";
import { getARandomNumberInRange } from "../scripts/scripts";
import "./MenuBar.css"

export const MenuBar = ({allYearlyEvents, addNewEvent}) => {
    const [usedEvents, setUsedEvents] = useState([])
    const getRandomNotUsedYearlyEvent = () => {
        const randomIndex = getARandomNumberInRange(0, allYearlyEvents.length)
        let foundRandomEvent = allYearlyEvents[randomIndex]
        if (!usedEvents.some(event => event === foundRandomEvent && allYearlyEvents.length))
        {
            console.log(foundRandomEvent)
            setUsedEvents((events) => [...events,allYearlyEvents[randomIndex]])
            addNewEvent(foundRandomEvent);
        }
        else {return getRandomNotUsedYearlyEvent();}
    }


    return(<><div className="menu-bar-container"><div className="menu-item"></div><div className="menu-item"></div><button id="menu-button"onClick={getRandomNotUsedYearlyEvent}>Advance Year</button><div className="menu-item"></div><div className="menu-item"></div></div><div className="menu-spacer"></div></>)
}