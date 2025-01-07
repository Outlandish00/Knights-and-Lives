import { useEffect, useState } from "react"
import { MenuBar } from "./MenuBar"
import { YearlyEventItem } from "./YearlyEventItem"
import"./MainScreen.css"
import { NewSimScreen } from "./NewSimScreen"

export const MainScreen = ({allYearlyEvents}) => {
    const [eventList, setEventList] = useState([])
    const [currentYear, setCurrentYear] = useState(0)
   // Add new event to the event list and increment the year
   const addNewEventToScreen = (event) => {
    const eventWithYear = {
        ...event,
        year: currentYear, // Attach the current year to the event
    }
    setEventList((previousList) => [...previousList, eventWithYear])
    setCurrentYear((prevYear) => prevYear + 1) // Increment the year for the next event
}

    //future use, was used for testing
    useEffect(() => {
        setCurrentYear(1200)
    }, [])

    //mood bars
    const [health, setHealth] = useState(50)
    const [hygeine, setHygeine] = useState (1)
    const [food, setFood] = useState(30)
    const [mood, setMood] = useState(60)

    //changes the bars color dynamically based on remaining stat
    const getBarColor = (bar) => {
        if (bar >= 75) return "#8da125";
        if (bar >= 50 && bar < 75) return "#65741b";
        if (bar >= 25 && bar < 50) return "#353d0e"
        return "black"
    }

    //setting up css variables
    const healthBarColor = getBarColor(health)
    const hygeineBarColor = getBarColor(hygeine)
    const foodBarColor = getBarColor(food)
    const moodBarColor = getBarColor(mood)

    //character information useState
    const [character, setCharacter] = useState({
        name: ""
    })
    const [familyName, setFamilyName] = useState({})
//useState to check if character has been created
    const [characterSet, setCharacterSet] = useState(false)
    useEffect(() => {
        setCharacterSet(false)
    }, [])
    console.log(characterSet);
     return (!characterSet ? <div className="screen-inner-container"> <NewSimScreen setFamilyName={setFamilyName} familyName={familyName}/> </div>: (<div className="screen-inner-container"><MenuBar currentYear={currentYear} setCurrentYear={setCurrentYear} allYearlyEvents={allYearlyEvents} addNewEvent={addNewEventToScreen}/><div className="yearly-event-screen"><ul className="event-list">{eventList.map((event) => (
        <li><YearlyEventItem currentYear={currentYear} event={event}/></li>
    ))}</ul></div><div className="header-screen"><div className="name-container"></div><div className="bars-name"><ul className="bars-names-list"><li>Health</li><li>Hygeine</li><li>Food</li><li>Mood</li></ul></div><div className="bars-container"><div className="hp-bar-outer" ><div className="hp-bar-inner" style={{ '--health-width': `${health}%`, "--bar-color": healthBarColor,}}></div></div><div className="hygeine-bar-outer"><div className="hygeine-bar-inner"style={{ '--hygeine-width': `${hygeine}%`, "--bar-color": hygeineBarColor,}}></div></div><div className="food-bar-outer"><div className="food-bar-inner" style={{ '--food-width': `${food}%`, "--bar-color": foodBarColor,}}></div></div><div className="mood-bar-outer"><div className="mood-bar-inner" style={{ '--mood-width': `${mood}%`, "--bar-color": moodBarColor,}}></div></div></div></div></div>));
}