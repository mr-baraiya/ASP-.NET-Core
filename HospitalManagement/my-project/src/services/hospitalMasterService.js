const API_BASE_URL = import.meta.env.VITE_API_BASE_URL;
const API_URL = `${API_BASE_URL}/api/HospitalMaster`;

export async function getAllHospitals() {
  const res = await fetch(API_URL);
  if (!res.ok) throw new Error('Failed to fetch hospitals');
  return res.json();
}

export async function getHospitalById(id) {
  const res = await fetch(`${API_URL}/${id}`);
  if (!res.ok) throw new Error('Failed to fetch hospital');
  return res.json();
}

export async function addHospital(hospital) {
  const res = await fetch(API_URL, {
    method: 'POST',
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify(hospital)
  });
  if (!res.ok) throw new Error('Failed to add hospital');
  return res.json();
}

export async function updateHospital(id, hospital) {
  const res = await fetch(`${API_URL}/${id}`, {
    method: 'PUT',
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify(hospital)
  });
  if (!res.ok) throw new Error('Failed to update hospital');
  return res.json();
}

export async function deleteHospital(id) {
  const res = await fetch(`${API_URL}/${id}`, { method: 'DELETE' });
  if (!res.ok) throw new Error('Failed to delete hospital');
  return res;
}

export async function getSuccess() {
  const res = await fetch(`${API_URL}/success`);
  if (!res.ok) throw new Error('Failed to fetch success');
  return res.json();
}

export async function getFail() {
  const res = await fetch(`${API_URL}/fail`);
  if (!res.ok) throw new Error('Failed to fetch fail');
  return res.json();
}