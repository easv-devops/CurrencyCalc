import http from 'k6/http'
import {sleep, check} from 'k6';

export const options = {
    stages: [
        {duration: '2m', target: 15},
        {duration: '1h', target: 15},
        {duration: '2m', target: 15},
    ]
};

export default () => {
    const res = http.get('http://localhost:5216/')
}