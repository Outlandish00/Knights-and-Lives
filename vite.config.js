import { defineConfig } from "vite";
import react from "@vitejs/plugin-react";

// https://vite.dev/config/
export default defineConfig({
  plugins: [react()],
  server: {
    port: 5173,
    proxy: {
      "/api": {
        target: "http://localhost:5119", // Your backend API URL
        changeOrigin: true, // Change origin of host header to match target
        secure: false, // Set to false if you're using HTTP (not HTTPS)
      },
    },
  },
});
