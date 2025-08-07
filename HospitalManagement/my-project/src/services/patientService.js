const API_BASE_URL = import.meta.env.VITE_API_BASE_URL;
const API_URL = `${API_BASE_URL}/api/Patients`;

export async function getAllPatients() {
  const res = await fetch(API_URL);
  if (!res.ok) throw new Error('Failed to fetch patients');
  return res.json();
}

export async function getPatientById(id) {
  const res = await fetch(`${API_URL}/${id}`);
  if (!res.ok) throw new Error('Failed to fetch patient');
  return res.json();
}

export async function addPatient(patient) {
  const res = await fetch(API_URL, {
    method: 'POST',
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify(patient)
  });
  if (!res.ok) throw new Error('Failed to add patient');
  return res.json();
}

export async function updatePatient(id, patient) {
  const res = await fetch(`${API_URL}/${id}`, {
    method: 'PUT',
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify(patient)
  });
  if (!res.ok) throw new Error('Failed to update patient');
  return res.json();
}

export async function deletePatient(id) {
  const res = await fetch(`${API_URL}/${id}`, { method: 'DELETE' });
  if (!res.ok) throw new Error('Failed to delete patient');
  return res;
}