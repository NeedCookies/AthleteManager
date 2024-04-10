import React, { useContext } from 'react';
import { ThemeContext } from "./context/theme.context"

function App() {
  const {darkMode} = useContext(ThemeContext);

  const appStyles = darkMode ? "dark mode" : "mode"
  
  return (
    <div className="App">
      App
    </div>
  );
}

export default App;
