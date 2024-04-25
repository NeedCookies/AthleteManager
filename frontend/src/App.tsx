import { useContext, lazy, Suspense } from "react";
import { ThemeContext } from "./context/theme.context";
import { Routes, Route } from "react-router-dom";
import Navbar from "./components/navbar/Navbar.component";
import CustomLinearProgress from "./components/CustomLinearProgress.component";

//Lazy loading
const Home = lazy(() => import("./pages/Home/Home.page"));

const App = () => {
  const { darkMode } = useContext(ThemeContext);

  const appStyles = darkMode ? "app dark" : "app";

  return (
    <div className={appStyles}>
      <Navbar />
      <div className="wrapper">
        <Suspense fallback={<CustomLinearProgress />}>
          <Routes>
            <Route path="/" element={<Home />} />
          </Routes>
        </Suspense>
      </div>
    </div>
  );
};

export default App;
