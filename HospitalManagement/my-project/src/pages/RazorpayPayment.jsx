import { useState } from "react";
import { motion } from "framer-motion";
import PayNowButton from "../components/RazorpayButton";

export default function PaymentPage() {
  const [amount, setAmount] = useState(1000); // default ₹10

  const handleAmountChange = (e) => {
    const value = e.target.value;
    setAmount(value === "" ? 0 : Number(value) * 100);
  };

  return (
    <div className="min-h-screen flex items-center justify-center bg-gradient-to-br from-gray-100 to-gray-200 px-4">
      <motion.div
        initial={{ opacity: 0, scale: 0.95, y: 30 }}
        animate={{ opacity: 1, scale: 1, y: 0 }}
        exit={{ opacity: 0, scale: 0.95, y: 30 }}
        transition={{ duration: 0.4, ease: "easeOut" }}
        className="bg-white p-8 rounded-2xl shadow-2xl w-full max-w-md space-y-6"
      >
        <h1 className="text-3xl font-bold text-center text-black">Make Payment</h1>
        <p className="text-sm text-center text-gray-500">Enter amount in ₹ (INR)</p>

        <label htmlFor="amount" className="sr-only">Amount</label>
        <input
          id="amount"
          type="number"
          min="1"
          step="0.01"
          inputMode="decimal"
          value={amount / 100 || ""}
          onChange={handleAmountChange}
          className="w-full p-3 border border-gray-300 text-black rounded-lg focus:outline-none focus:ring-2 focus:ring-blue-500 focus:border-transparent transition"
          placeholder="Enter amount"
        />

        <div className="pt-4">
          <PayNowButton amount={amount} className="w-full" />
        </div>
      </motion.div>
    </div>
  );
}
