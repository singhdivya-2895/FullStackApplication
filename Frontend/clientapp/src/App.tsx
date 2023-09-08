import React, { useEffect, useState } from 'react';
import axios from 'axios';
import { Header, List } from 'semantic-ui-react';

function App() {
  const [activities, setActivities] = useState([]);

  useEffect(() => {
    const fetchData = async () => {
      const response = await axios.get('http://localhost:5000/api/activities');
      console.log(response);
      setActivities(response.data)
    }
    fetchData();
  }, [])

  return (
    <div>
      <Header as='h2' icon='users' content='Reactivities' />
      <List>
        {
          activities.map((activity: any) => {
            return (
              <List.Item key={activity.id}>
                {activity.title}
              </List.Item>
            );
          })
        }
      </List>
    </div>
  );
}

export default App;


