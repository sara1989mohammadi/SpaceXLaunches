import React from "react";
import { render, screen } from "@testing-library/react";
import LaunchList from "./LaunchList";
import useHttp from "../../hooks/use-http";
import LaunchContext, {
  LaunchContextProvider,
} from "../../store/LaunchContext";
jest.mock("../../hooks/use-http.js");
test("renders launch name correctly", () => {
  const myInitialState = [
    {
      flight_number: 1,
      mission_name: "FalconSat",
      mission_id: null,
      upcoming: false,
      launch_year: "2006",
      launch_date_unix: 1143239400,
      launch_date_utc: "2006-03-24T22:30:00Z",
      launch_date_local: "2006-03-24T23:30:00+01:00",
      is_tentative: false,
      tentative_max_precision: "hour",
      tbd: false,
      launch_window: 0,
      rocket: null,
      ships: null,
      telemetry: null,
      launch_site: null,
      launch_success: false,
      launch_failure_details: null,
      links: {
        mission_patch: "https://images2.imgbox.com/40/e3/GypSkayF_o.png",
        mission_patch_small: "https://images2.imgbox.com/3c/0e/T8iJcSN3_o.png",
        reddit_campaign: null,
        reddit_launch: null,
        reddit_recovery: null,
        reddit_media: null,
        presskit: null,
        article_link:
          "https://www.space.com/2196-spacex-inaugural-falcon-1-rocket-lost-launch.html",
        wikipedia: "https://en.wikipedia.org/wiki/DemoSat",
        video_link: "https://www.youtube.com/watch?v=0a_00nJ_Y88",
        youtube_id: "0a_00nJ_Y88",
        flickr_images: null,
        id: 1,
      },
      details: "Engine failure at 33 seconds and loss of vehicle",
      static_fire_date_utc: "2006-03-17T00:00:00Z",
      static_fire_date_unix: 1142553600,
      timeline: null,
      crew: null,
      last_date_update: null,
      last_ll_launch_date: null,
      last_ll_update: null,
      last_wiki_launch_date: null,
      last_wiki_revision: null,
      last_wiki_update: null,
      launch_date_source: null,
      id: 1,
    },
  ];
  useHttp.mockReturnValue({
    sendRequest: jest.fn(),
    status: "completed",
    data: myInitialState,
    error: null,
  });

  const setItemsHandler = (list) => {

  };

  render(
    <LaunchContext.Provider
      value={{
        setItems: setItemsHandler,
        items: myInitialState,
      }}>
      <LaunchList />
    </LaunchContext.Provider>
  );

  const launchName = screen.getByText("FalconSat");
  expect(launchName).toBeInTheDocument();
});
