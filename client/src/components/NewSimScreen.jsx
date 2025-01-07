import { useEffect, useState } from "react"
import "./NewSimScreen.css"
import { getAllFamilyNames } from "../scripts/apiManager"
export const NewSimScreen = ({setFamilyName, familyName}) => {

    const [familyNames, setFamilyNames] = useState([])

    useEffect(() => {
        getAllFamilyNames().then((data) => setFamilyNames(data))
    }, [])

     const getRandomFamilyName = () => {
        const randomNumber = Math.random();
        if (randomNumber < 0.994)
        {
            const peasants = familyNames.filter((item) => item.isPeasant);
            const randomNumberForPeasant = Math.floor(Math.random()* peasants.length);
            setFamilyName(peasants[randomNumberForPeasant])
            return peasants[randomNumberForPeasant];
        }
        else if (randomNumber < 0.999) {
            const warriors = familyNames.filter((item) => item.isWarrior);
            const randomNumberForWarrior = Math.floor(Math.random() * warriors.length);
            setFamilyName(warriors[randomNumberForWarrior])
            return warriors[randomNumberForWarrior]
        }
        else {
            const royalty = familyNames.filter((item) => item.isRoyalty)
            const randomNumberForRoyalty = Math.floor(Math.random()* royalty.length)
            setFamilyName(royalty[randomNumberForRoyalty])
            return royalty[randomNumberForRoyalty]
        }

    }

    return (<div className="new-sim-container"><div className="game-title"><img src="../client/public/Knight and Lives title.png" className="game-title-text"/></div><div className="name-input-container"><h2> Name</h2><input className="name-input-box"></input> <div className="family-name-container"><button onClick={getRandomFamilyName}>Reroll</button> {familyName.name}</div></div><div className="start-btn-container"><button>Start your adventure</button></div></div>)
}