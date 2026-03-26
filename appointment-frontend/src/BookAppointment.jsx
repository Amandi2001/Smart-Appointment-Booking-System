import { useState } from "react";
import axios from "axios";

function BookAppointment() {
  const [data, setData] = useState({
    userId: "",
    serviceId: "",
    appointmentDate: ""
  });

  const handleSubmit = async (e) => {
    e.preventDefault();
    await axios.post("https://localhost:5001/api/appointment", data);
    alert("Appointment Booked!");
  };

  return (
    <div className="container mt-5">
      <h2>Book Appointment</h2>
      <form onSubmit={handleSubmit}>
        <input className="form-control mb-2" placeholder="User ID"
          onChange={(e)=>setData({...data,userId:e.target.value})} />

        <input className="form-control mb-2" placeholder="Service ID"
          onChange={(e)=>setData({...data,serviceId:e.target.value})} />

        <input type="datetime-local" className="form-control mb-2"
          onChange={(e)=>setData({...data,appointmentDate:e.target.value})} />

        <button className="btn btn-primary">Book</button>
      </form>
    </div>
  );
}

export default BookAppointment;