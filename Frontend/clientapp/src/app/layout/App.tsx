import React, { useEffect, useState } from 'react';
import axios from 'axios';
import { Container } from 'semantic-ui-react';
import { Activity } from '../models/activity';
import NavBar from './NavBar';
import ActivityDashboard from '../../features/activities/dashboard/ActivityDashboard';

function App() {
  const [activities, setActivities] = useState<Activity[]>([]);
  const [selectedActivity, setSelectedActivity] = useState<Activity | undefined>(undefined);
  const [editMode, setEditMode] = useState(false);

  useEffect(() => {
    const fetchData = async () => {
      const response = await axios.get<Activity[]>('http://localhost:5000/api/activities');
      console.log(response);
      setActivities(response.data)
    }
    fetchData();
  }, [])

  function handleSelectActivity(id: string) {
    setSelectedActivity(activities.find(x => x.id === id));
  }

  function handleCancelActivity() {
    setSelectedActivity(undefined);
  }
  function handleFormOpen(id?: string) {
    id ? handleSelectActivity(id) : handleCancelActivity();
    setEditMode(true);
  }
  function handleFormClose() {
    setEditMode(false);
  }

  return (
    <>
      <NavBar openForm={handleFormOpen} />
      <Container style={{ marginTop: '7em' }}>
        <ActivityDashboard
          activities={activities}
          selectedActivity={selectedActivity}
          selectActivity={handleSelectActivity}
          cancelSelectActivity={handleCancelActivity}
          editMode={editMode}
          openForm={handleFormOpen}
          closeForm={handleFormClose}
        />
      </Container>
    </>
  );
}

export default App;


