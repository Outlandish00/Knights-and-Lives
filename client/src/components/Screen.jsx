import { useEffect, useState } from "react";
import { getAllYearlyEvents } from "../scripts/apiManager";
import { MenuBar } from "./MenuBar"
import "./Screen.css"
import { MainScreen } from "./MainScreen";

export const Screen = () => {
    const [allYearlyEvents, setAllYearlyEvents] = useState([])
    useEffect(() => {
        getAllYearlyEvents().then((data) => setAllYearlyEvents(data),console.log(allYearlyEvents))
        
    }, [])
    return (<div className="screen-container"><MainScreen allYearlyEvents={allYearlyEvents}/></div>)
}