import "./App.css";
import { Container, Card, TextField, Box } from "@mui/material";

function App() {
  return (
    <Card>
      <div className="d-flex">
        <div className="col">
          <TextField placeholder="User..."></TextField>
        </div>
        <div className="col">
          <TextField placeholder="Room..."></TextField>
        </div>
      </div>
    </Card>
  );
}

export default App;
