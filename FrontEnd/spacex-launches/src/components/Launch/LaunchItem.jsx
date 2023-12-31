import React, { useContext } from "react";
import LaunchContext from "../../store/LaunchContext";

function LaunchItem(props) {
  const ctx = useContext(LaunchContext);

  const showDetailsHandler = (id) => {
    ctx.showDetails(true);
    ctx.selectedItem(id);
  };
  const date = new Date(props.launch.launch_date_utc);
  const month = date.toLocaleString("en-US", { month: "2-digit" });
  const day = date.toLocaleString("en-US", { day: "2-digit" });
  const year = date.getFullYear();

  return (
    <tr>
      <td className="px-5 py-5 border-b border-gray-200 bg-white text-sm">
        <div className="flex">
          <div className="flex-shrink-0 w-10 h-10">
            <img
              className="w-full h-full rounded-full"
              src={props.launch.links.mission_patch_small}
              alt=""
            />
          </div>
          <div className="ml-3">
            <p className="text-gray-900 whitespace-no-wrap">
              {props.launch.mission_name}
            </p>
            <p className="text-gray-600 whitespace-no-wrap">
              {props.launch.flight_number}
            </p>
          </div>
        </div>
      </td>

      <td className="px-5 py-5 border-b border-gray-200 bg-white text-sm">
        <p className="text-gray-900 whitespace-no-wrap">
          {props.launch.details}
        </p>
      </td>
      <td className="px-5 py-5 border-b border-gray-200 bg-white text-sm">
        <p className="text-gray-900 whitespace-no-wrap">
          {day}/{month}/{year}
        </p>
      </td>
      <td className="px-5 py-5 border-b border-gray-200 bg-white text-sm">
        {props.launch.launch_success && (
          <span className="relative inline-block px-3 py-1 font-semibold text-green-900 leading-tight">
            <span
              aria-hidden
              className="absolute inset-0 bg-green-200 opacity-50 rounded-full"></span>
            <span className="relative"> Yes</span>{" "}
          </span>
        )}
        {!props.launch.launch_success && (
          <span className="relative inline-block px-3 py-1 font-semibold text-red-900 leading-tight">
            <span
              aria-hidden
              className="absolute inset-0 bg-red-200 opacity-50 rounded-full"></span>
            <span className="relative"> No</span>{" "}
          </span>
        )}
      </td>
      <td className="px-5 py-5 border-b border-gray-200 bg-white text-sm text-right">
        <button
          onClick={() => showDetailsHandler(props.launch.id)}
          className="rounded-md bg-indigo-600 px-3 py-2 text-sm font-semibold text-white shadow-sm hover:bg-indigo-500 focus-visible:outline focus-visible:outline-2 focus-visible:outline-offset-2 focus-visible:outline-indigo-600">
          Detail
        </button>
      </td>
    </tr>
  );
}

export default LaunchItem;
