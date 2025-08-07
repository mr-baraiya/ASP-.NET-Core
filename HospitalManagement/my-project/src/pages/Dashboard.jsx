import { motion } from 'framer-motion';

const cards = [
  {
    title: 'Doctors',
    description: 'Manage all doctors in the hospital.',
    color: 'from-blue-400 to-blue-600',
    icon: (
      <svg className="w-10 h-10 mb-2 text-white" fill="none" stroke="currentColor" strokeWidth="2" viewBox="0 0 24 24"><path strokeLinecap="round" strokeLinejoin="round" d="M12 14v7m0 0H9m3 0h3m-3-7a5 5 0 100-10 5 5 0 000 10zm7 7v-2a4 4 0 00-4-4H9a4 4 0 00-4 4v2" /></svg>
    ),
    link: '/doctors',
  },
  {
    title: 'Hospitals',
    description: 'View and edit hospital information.',
    color: 'from-green-400 to-green-600',
    icon: (
      <svg className="w-10 h-10 mb-2 text-white" fill="none" stroke="currentColor" strokeWidth="2" viewBox="0 0 24 24"><path strokeLinecap="round" strokeLinejoin="round" d="M3 21v-2a4 4 0 014-4h10a4 4 0 014 4v2M16 3.13a4 4 0 01.84 7.9M8 3.13a4 4 0 00-.84 7.9" /></svg>
    ),
    link: '/hospitalmaster',
  },
  {
    title: 'Patients',
    description: 'Track and manage patient records.',
    color: 'from-yellow-400 to-yellow-600',
    icon: (
      <svg className="w-10 h-10 mb-2 text-white" fill="none" stroke="currentColor" strokeWidth="2" viewBox="0 0 24 24"><path strokeLinecap="round" strokeLinejoin="round" d="M5.121 17.804A13.937 13.937 0 0112 15c2.5 0 4.847.655 6.879 1.804M15 10a3 3 0 11-6 0 3 3 0 016 0z" /></svg>
    ),
    link: '/patients',
  },
];

function Dashboard() {
  return (
    <div className="p-8 min-h-screen bg-gradient-to-br from-gray-100 to-gray-200">
      <h1 className="text-4xl font-extrabold mb-8 text-gray-800 text-center tracking-tight">Welcome to Hospital Management Dashboard</h1>
      <div className="grid grid-cols-1 md:grid-cols-3 gap-8 max-w-5xl mx-auto">
        {cards.map((card, i) => (
          <motion.a
            href={card.link}
            key={card.title}
            whileHover={{ scale: 1.06, boxShadow: '0 8px 32px rgba(0,0,0,0.18)' }}
            whileTap={{ scale: 0.98 }}
            initial={{ opacity: 0, y: 40 }}
            animate={{ opacity: 1, y: 0 }}
            transition={{ delay: i * 0.15, type: 'spring', stiffness: 120 }}
            className={`rounded-2xl shadow-lg bg-gradient-to-br ${card.color} p-8 flex flex-col items-center cursor-pointer hover:shadow-2xl transition`}
          >
            {card.icon}
            <h2 className="text-2xl font-bold text-white mb-2">{card.title}</h2>
            <p className="text-white text-center text-lg opacity-90">{card.description}</p>
          </motion.a>
        ))}
      </div>
    </div>
  );
}

export default Dashboard;