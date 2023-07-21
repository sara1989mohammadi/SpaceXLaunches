import React, { Fragment, useContext, useEffect } from "react";
import useHttp from "../../hooks/use-http";
import { getAll } from "../../lib/api";
import LaunchItem from "./LaunchItem";
import LaunchContext from "../../store/LaunchContext";
import Loading from "../UI/Loading";

function LaunchList() {
  const ctx = useContext(LaunchContext);
  const { sendRequest, status, data, error } = useHttp(getAll, true);

  useEffect(() => {
    async function fetchData() {
      await sendRequest();
    }

    fetchData();
  }, [sendRequest]);

  if (status === "pending") {
    return <Loading />;
  }
  ctx.setItems(data);
  
  return (
    <Fragment>
      <div>
        <h2 className="text-2xl font-semibold leading-tight">Launches</h2>
      </div>
      <div className="-mx-4 sm:-mx-8 px-4 sm:px-8 py-4 overflow-x-auto">
        <div className="inline-block min-w-full shadow-md rounded-lg overflow-hidden">
          <table className="min-w-full leading-normal">
            <thead>
              <tr>
                <th className="px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider">
                  Mission Name
                </th>
                <th className="px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider">
                  Details
                </th>
                <th className="px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider">
                  Date
                </th>
                <th className="px-5 py-3 border-b-2 border-gray-200 bg-gray-100 text-left text-xs font-semibold text-gray-700 uppercase tracking-wider">
                  success
                </th>
                <th className="px-5 py-3 border-b-2 border-gray-200 bg-gray-100"></th>
              </tr>
            </thead>
            <tbody>
              {ctx.items.map((launch) => (
                <LaunchItem key={launch.id} launch={launch} />
              ))}
            </tbody>
          </table>
        </div>
      </div>
    </Fragment>
  );
}

export default LaunchList;
