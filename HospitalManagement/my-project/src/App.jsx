import { BrowserRouter as Router, Routes, Route, Link, Navigate } from 'react-router-dom';
import Dashboard from './pages/Dashboard.jsx';
import PaymentPage from './pages/RazorpayPayment.jsx';

function Sidebar() {
  return (
    <div className="w-64 h-full bg-gray-900 text-white flex flex-col p-6">
      <h2 className="text-2xl font-bold mb-8">Hospital Management</h2>
      <nav className="flex-1">
        <ul className="space-y-4">
          <li>
            <Link className="hover:text-blue-400" to="/dashboard">Dashboard</Link>
          </li>
          <li>
            <Link className="hover:text-blue-400" to="/payment">Payment</Link>
          </li>
        </ul>
      </nav>
    </div>
  );
}

function Header() {
  return (
    <header className="bg-white shadow px-8 py-4 flex items-center justify-between sticky top-0 z-10">
      <span className="text-xl font-semibold text-gray-800">Hospital Management System</span>
      <span className="text-gray-500">Admin</span>
    </header>
  );
}

function App() {
  return (
    <Router>
      <div className="flex h-screen overflow-hidden">
        {/* Sidebar container with fixed width */}
        <div className="w-64 flex-shrink-0 h-screen sticky top-0">
          <Sidebar />
        </div>

        {/* Main content area */}
        <div className="flex flex-col flex-1 overflow-hidden">
          <Header />
          <main className="flex-1 overflow-y-auto bg-gray-50 p-6">
            <Routes>
              <Route path="/" element={<Navigate to="/dashboard" replace />} />
              <Route path="/dashboard" element={<Dashboard />} />
              <Route path="/payment" element={<PaymentPage />} />
            </Routes>
          </main>
        </div>
      </div>
    </Router>
  );
}

export default App;
