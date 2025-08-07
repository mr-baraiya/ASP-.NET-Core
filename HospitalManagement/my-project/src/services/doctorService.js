const API_BASE_URL = import.meta.env.VITE_API_BASE_URL;
const API_URL = `${API_BASE_URL}/api/Doctors`;

export async function getAllDoctors() {
  const res = await fetch(API_URL);
  if (!res.ok) throw new Error('Failed to fetch doctors');
  return res.json();
}

export async function getDoctorById(id) {
  const res = await fetch(`${API_URL}/${id}`);
  if (!res.ok) throw new Error('Failed to fetch doctor');
  return res.json();
}

export async function addDoctor(doctor) {
  const res = await fetch(API_URL, {
    method: 'POST',
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify(doctor)
  });
  if (!res.ok) throw new Error('Failed to add doctor');
  return res.json();
}

export async function updateDoctor(id, doctor) {
  const res = await fetch(`${API_URL}/${id}`, {
    method: 'PUT',
    headers: { 'Content-Type': 'application/json' },
    body: JSON.stringify(doctor)
  });
  if (!res.ok) throw new Error('Failed to update doctor');
  return res.json();
}

export async function deleteDoctor(id) {
  const res = await fetch(`${API_URL}/${id}`, { method: 'DELETE' });
  if (!res.ok) throw new Error('Failed to delete doctor');
  return res;
}