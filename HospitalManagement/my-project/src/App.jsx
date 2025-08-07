import { BrowserRouter as Router, Routes, Route, Link, Navigate } from 'react-router-dom';
import Dashboard from './pages/Dashboard.jsx';
import DoctorsPage from './pages/DoctorsPage.jsx';
import HospitalMasterPage from './pages/HospitalMasterPage.jsx';
import PatientsPage from './pages/PatientsPage.jsx';

function Sidebar() {
  return (
    <aside className="bg-gray-900 text-white w-64 min-h-screen flex flex-col p-6">
      <h2 className="text-2xl font-bold mb-8">Hospital Management</h2>
      <nav className="flex-1">
        <ul className="space-y-4">
          <li><Link className="hover:text-blue-400" to="/dashboard">Dashboard</Link></li>
          <li><Link className="hover:text-blue-400" to="/doctors">Doctors</Link></li>
          <li><Link className="hover:text-blue-400" to="/hospitalmaster">HospitalMaster</Link></li>
          <li><Link className="hover:text-blue-400" to="/patients">Patients</Link></li>
        </ul>
      </nav>
    </aside>
  );
}

function Header() {
  return (
    <header className="bg-white shadow px-8 py-4 flex items-center justify-between">
      <span className="text-xl font-semibold text-gray-800">Hospital Management System</span>
      <span className="text-gray-500">Admin</span>
    </header>
  );
}

function App() {
  return (
    <Router>
      <div className="flex min-h-screen h-screen">
        <Sidebar />
        <div className="flex-1 flex flex-col">
          <Header />
          <main className="flex-1 bg-gray-50 p-6 overflow-auto">
            <Routes>
              <Route path="/" element={<Navigate to="/dashboard" replace />} />
              <Route path="/dashboard" element={<Dashboard />} />
              <Route path="/doctors" element={<DoctorsPage />} />
              <Route path="/hospitalmaster" element={<HospitalMasterPage />} />
              <Route path="/patients" element={<PatientsPage />} />
            </Routes>
          </main>
        </div>
      </div>
    </Router>
  );
}

export default App;
