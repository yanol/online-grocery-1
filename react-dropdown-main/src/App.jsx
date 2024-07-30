import "./App.css";
import axios from 'axios';

import Dropdown from "./components/Dropdown/Dropdown";
import DropdownItem from "./components/DropdownItem/DropdownItem";
import LoginForm from "./components/LoginForm/LoginForm";
import ProceedOrderButton from "./components/ProceedOrder/ProceedOrder";


const App = () => {
  const items = [1, 2, 3, 4, 5, 6, 7, 8];

  const handleOrder = async () =>{

      console.log("Clicked");

      try {
        const res = await axios.post('http://localhost:3008/user', { data });
        setResponse(res.data);
      } catch (error) {
        console.error('Error sending data:', error);
      }
  }

  const handleGetCategory = async () =>{
    
    console.log("Clicked");

    try {
      const res = await axios.get('http://localhost:5000/category', {  });
      setResponse(res.data);
    } catch (error) {
      console.error('Error sending data:', error);
    }

    
}

  return (
    <div className="App">
      <div className="content">

      <button type="button" onClick={handleOrder}> Click!!! </button>

      <Dropdown buttonText="Login" content={<LoginForm />} />

        <Dropdown
          buttonText="Chose category"
          content={
            <>
              {items.map((item, id) => (
                <DropdownItem key={id}>{`Item ${handleGetCategory}`}</DropdownItem>
              ))}
            </>
          }
        />

  <Dropdown
          buttonText="Chose grocery"
          content={
            <>
              {items.map((item, id) => (
                <DropdownItem key={id}>{`Item ${item}`}</DropdownItem>
              ))}
            </>
          }
        />
      </div>
    </div>
  );
};

export default App;
