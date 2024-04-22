import './navbar.scss';
import {Link} from "react-router-dom";
import {Menu, LightMode, DarkMode} from "@mui/icons-material";
import { ToggleButton } from '@mui/material';
import { useContext } from 'react';
import {ThemeContext} from "../../context/theme.context"

const links = [
    {href : "/", label: "Home"},
    {href: "/sports", label: "Sports" },
    {href: "/competitions", label: "Competitions"},
    {href: "/athletes", label: "Athletes"}
]

const Navbar = () => {
    const {darkMode, toggleDarkMode} = useContext(ThemeContext);
    return (
        <div className='navbar'>
            <div className='brand'>
                <span>Resume Management</span>
            </div>
            <div className='menu'></div>
                <ul>
                    {links.map((item) => (
                        <li key={item.href}>
                            <Link to={item.href}>{item.label}</Link>
                        </li>
                    ))}
                </ul>
            <div className='hmm'>
                <Menu />
            </div>
            <div className='toggle'>
                <ToggleButton value={"check"} selected={darkMode} onChange={toggleDarkMode}>
                    {darkMode ? <LightMode/> : <DarkMode />}
                </ToggleButton>
            </div>
        </div>
    )
}

export default Navbar