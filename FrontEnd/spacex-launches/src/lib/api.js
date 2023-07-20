const BASE_DOMAIN = "https://localhost:7099/api";

export async function getAll() {
  const response = await fetch(`${BASE_DOMAIN}/Launche`);
  const data = await response.json();

  if (!response.ok) {
    throw new Error(data.message || "Could not fetch launch.");
  }
  return data;
}

export async function getById(launchId) {
  const response = await fetch(`${BASE_DOMAIN}/Launche/${launchId}`);
  const data = await response.json();

  if (!response.ok) {
    throw new Error(data.message || "Could not fetch launch.");
  }

  return data;
}
