import React, { useState, useEffect } from "react";

const LaunchContext = React.createContext({
  items: [],
  setItems: (list) => {},
  isShowDetails: false,
  showDetails: (isShow) => {},
  selectedItem: (id) => {},
  selectId: 0,
});

export const LaunchContextProvider = (props) => {
  const [items, setItems] = useState([]);
  const [isShowDetails, setIsShowDetails] = useState(false);
  const [selectId, setSelectId] = useState(0);

  const showDetailsHandler = (isShow) => {
    setIsShowDetails(isShow);
  };

  const setItemsHandler = (list) => {
    setItems(list);
  };

  const selectedItemHandler = (selectId) => {
    setSelectId(selectId);
  };

  return (
    <LaunchContext.Provider
      value={{
        items: items,
        setItems: setItemsHandler,
        isShowDetails: isShowDetails,
        showDetails: showDetailsHandler,
        selectedItem: selectedItemHandler,
        selectId: selectId,
      }}>
      {props.children}
    </LaunchContext.Provider>
  );
};

export default LaunchContext;
