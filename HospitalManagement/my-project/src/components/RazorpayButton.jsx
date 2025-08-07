import { useEffect, useState } from "react";
import { motion } from "framer-motion";

export default function PayNowButton({ amount }) {
  const [isScriptLoaded, setIsScriptLoaded] = useState(false);

  // Dynamically load Razorpay script
  useEffect(() => {
    const script = document.createElement("script");
    script.src = "https://checkout.razorpay.com/v1/checkout.js";
    script.async = true;
    script.onload = () => setIsScriptLoaded(true);
    script.onerror = () => {
      console.error("❌ Razorpay SDK failed to load.");
      alert("Failed to load Razorpay SDK. Try again later.");
    };
    document.body.appendChild(script);

    return () => {
      // Clean up script on unmount
      document.body.removeChild(script);
    };
  }, []);

  const handlePayment = async () => {
    if (!isScriptLoaded || !window.Razorpay) {
      console.error("❌ Razorpay SDK not ready.");
      return alert("Payment system not ready. Try again shortly.");
    }

    if (!amount || isNaN(amount)) {
      return alert("Invalid amount.");
    }

    try {
      const response = await fetch(
        `${import.meta.env.VITE_API_BASE_URL}/api/Payment/create-order`,
        {
          method: "POST",
          headers: { "Content-Type": "application/json" },
          body: JSON.stringify( amount ),
        }
      );

      const data = await response.json();

      if (!response.ok || data.error) {
        console.error("❌ Order creation failed:", data);
        return alert("Failed to create Razorpay order. Please try again.");
      }

      if (!data.id || !data.amount) {
        console.error("❌ Incomplete order data:", data);
        return alert("Invalid Razorpay order data.");
      }

      const razorpayKey = import.meta.env.VITE_RAZORPAY_KEY_ID;
      if (!razorpayKey) {
        return alert("Razorpay Key ID is missing in environment variables.");
      }

      const options = {
        key: razorpayKey,
        amount: data.amount.toString(),
        currency: data.currency || "INR",
        name: "Agri-Pay",
        description: "Eco-friendly Payment",
        order_id: data.id,
        handler: (response) => {
          console.log("✅ Payment Success:", response);
          alert("Payment successful! 🎉");
        },
        prefill: {
          name: "Vishal Baraiya",
          email: "example@email.com",
          contact: "9999999999",
        },
        theme: { color: "#22c55e" },
      };

      const rzp = new window.Razorpay(options);
      rzp.open();
    } catch (error) {
      console.error("❌ Payment Error:", error);
      alert("Something went wrong. Please try again.");
    }
  };

  return (
    <motion.button
      whileTap={{ scale: 0.95 }}
      whileHover={{ scale: 1.05 }}
      onClick={handlePayment}
      className="px-6 py-3 bg-green-600 text-white rounded-lg font-semibold shadow hover:bg-green-700"
    >
      Pay ₹{(amount / 100).toFixed(2)}
    </motion.button>
  );
}
