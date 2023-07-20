import "./App.css";
import Launch from "./components/Launch/Launch";
import { LaunchContextProvider } from "./store/LaunchContext";

function App() {
  return (
    <LaunchContextProvider>
      <Launch />
    </LaunchContextProvider>
  );
}

export default App;
