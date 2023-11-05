import { useEffect, useState } from 'react';
import './App.css';
import axios from 'axios';
import { Header, List } from 'semantic-ui-react';

const App = () => {
    /* States */
    const [activities, setActivities] = useState([]);

    /* Effects */
    useEffect(() => {
        axios.get('http://localhost:5000/api/activities').then((response) => {
            setActivities(response.data);
        });
    }, []);

    return (
        <>
            <Header as="h1" icon="users" content="Reactivites" />
            <List>
                {activities.map((activity: any) => (
                    <List.Item key={activity.id}>{activity.title}</List.Item>
                ))}
            </List>
        </>
    );
};

export default App;
