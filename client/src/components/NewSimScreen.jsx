import { useEffect, useState } from "react"
import "./NewSimScreen.css"
import { getAllFamilyNames } from "../scripts/apiManager"
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faPlay } from "@fortawesome/free-solid-svg-icons";
export const NewSimScreen = ({setFamilyName, familyName, setCharacter, setCharacterSet}) => {

    const [familyNames, setFamilyNames] = useState([])
    const [isShaking, setIsShaking] = useState(false)
    const [isHovered, setIsHovered] = useState(false)
    const [firstName, setFirstName] = useState("")
    useEffect(() => {
        getAllFamilyNames().then((data) => setFamilyNames(data))
    }, [])


     const getRandomFamilyName = () => {
        const randomNumber = Math.random();
        if (randomNumber < 0.7)
        {
            const peasants = familyNames.filter((item) => item.isPeasant);
            const randomNumberForPeasant = Math.floor(Math.random()* peasants.length);
            setFamilyName(peasants[randomNumberForPeasant])
            setIsShaking(true)
            setTimeout(() => {
                setIsShaking(false);
            }, 500);
            return peasants[randomNumberForPeasant];
        }
        else if (randomNumber < 0.9) {
            const warriors = familyNames.filter((item) => item.isWarrior);
            const randomNumberForWarrior = Math.floor(Math.random() * warriors.length);
            setFamilyName(warriors[randomNumberForWarrior])
            setIsShaking(true)
            setTimeout(() => {
                setIsShaking(false);
            }, 500);
            return warriors[randomNumberForWarrior]
        }
        else {
            const royalty = familyNames.filter((item) => item.isRoyalty)
            const randomNumberForRoyalty = Math.floor(Math.random()* royalty.length)
            setFamilyName(royalty[randomNumberForRoyalty])
            setIsShaking(true)
            setTimeout(() => {
                setIsShaking(false);
            }, 100);
            return royalty[randomNumberForRoyalty]
        }

    }
    const handleFirstNameChange = (event) => {
        setFirstName(event.target.value)
    }
    const handleMouseEnter = () => {
        setIsHovered(true)
    }

    const handleMouseLeave = () => {
        setIsHovered(true)
    }
    const handleStart = () => {
        if (firstName != ""){
            setCharacter(firstName)
            setCharacterSet(true)
        }
        else {
            window.alert("Please fill out name!")
        }
    }

    return (<div className="new-sim-container"><div className="game-title"><h2 className="game-title-text">Knights & Lives</h2></div><div className="name-input-container"><h2 className="name-text-input"> Name:</h2><div className="input-and-family-container"><input onChange={handleFirstNameChange}className="name-input-box"></input> <div className="family-name-container"><div className="reroll-btn-icon"><button className="reroll-button" onMouseEnter={handleMouseEnter} onMouseLeave={handleMouseLeave} onClick={getRandomFamilyName}>Reroll</button>{isHovered ? <FontAwesomeIcon className="play-btn-icon" icon={faPlay} /> : ""}</div><h2 className={`family-name-text ${isShaking? `shake` : ``}`}>{familyName.name}</h2></div></div></div><div className="start-btn-container"><button onClick={handleStart}className="start-btn">Start your adventure</button></div></div>)
}