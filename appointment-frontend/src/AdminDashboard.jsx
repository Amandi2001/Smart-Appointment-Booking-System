import { useEffect, useState } from "react";
import axios from "axios";

function AdminDashboard() {
  const [appointments, setAppointments] = useState([]);

  useEffect(() => {
    axios.get("https://localhost:5001/api/appointment")
      .then(res => setAppointments(res.data));
  }, []);

  return (
    <div className="container mt-5">
      <h2>Appointments</h2>
      <table className="table">
        <thead>
          <tr>
            <th>User</th>
            <th>Service</th>
            <th>Date</th>
            <th>Status</th>
          </tr>
        </thead>
        <tbody>
          {appointments.map(a => (
            <tr key={a.id}>
              <td>{a.userId}</td>
              <td>{a.serviceId}</td>
              <td>{a.appointmentDate}</td>
              <td>{a.status}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
}

export default AdminDashboard;