const { Client } = require('@elastic/elasticsearch');

// Create a new Elasticsearch client
const client = new Client({ node: 'http://localhost:9200' });

// Sample data to insert
/* const userData = [
  { id: 1, name: 'Alice', email: 'alice@example.com' },
  { id: 2, name: 'Bob', email: 'bob@example.com' },
  { id: 3, name: 'Charlie', email: 'charlie@example.com' }
];  */


// Function to insert data into Elasticsearch
async function insertData(userData) {
    await client.index(
        {
            index: 'users',
            body: userData
            // body: {
            //     userId: '1',
            //     userName: 'Michael',
            //     userEmail: 'mike30@walla.com',
            //     userAddress: 'Tel Aviv'
            //     }
            
        }
    );

  /* for (const user of userData) {
    await client.index({
      index: 'users',
      id: user.id,
      body: user
    }); */


  // Refresh the index to make the documents searchable immediately
  await client.indices.refresh({ index: 'users' });

  console.log('Data inserted successfully');
}

module.exports = { insertData };
// Execute the insertData function
// insertData().catch(console.log);
