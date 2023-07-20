import React, { useContext } from "react";
import LaunchList from "./LaunchList";
import LaunchContext from "../../store/LaunchContext";
import LaunchDetails from "./LaunchDetails";

const Launch = () => {
  const ctx = useContext(LaunchContext);
  return (
    <div className="container mx-auto px-4 sm:px-8">
      <div className="py-8">
        {!ctx.isShowDetails && <LaunchList />}
        {ctx.isShowDetails && <LaunchDetails />}
      </div>
    </div>
  );
};

export default Launch;
