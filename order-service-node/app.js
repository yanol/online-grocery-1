
const express = require('express');
const {insertData }= require('./src/index');
const cors = require('cors');

const app = express();
const port = 3008;

app.use(express.json());
app.use(cors());

app.get('/', (req, res) => {
  res.send('Hello, World!');
});

app.listen(port, () => {
  console.log(`Server is running on http://localhost:${port}`);
});

app.post('/user', async (req, res) => {
    // const userId = req.params.id;
    // const  userName = req.params.userName;
    // const userEmail = req.params.userEmail;
    // const userAddress = req.params.userAddress;

    // const userData = { userId, userName, userEmail, userAddress};
    /* const userData = {
      userId: '1',
      userName: 'Michael',
      userEmail: 'mike30@walla.com',
      userAddress: 'Tel Aviv'
      }
 */
    try {
      await insertData(req.body);

      res.json(req.body);
    }
    catch (error) {

      res.status(500).json({ message: error.message });
      console.error('Error inserting data:', error);
    }

    console.log("the order where saved succesefully");

  });

