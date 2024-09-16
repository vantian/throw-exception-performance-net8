import http from 'k6/http';
import { check, sleep } from 'k6';
export const options = {
    vus: 10,
    duration: '1m',
    insecureSkipTlsVerify: true,
};
export default function () {
    const url = 'https://localhost:7003/customer';
    const payload = JSON.stringify({
        name: "",
        email: "test@mail.com"
    });
    const params = {
        headers: {
            'Content-Type': 'application/json',
        }
    };

    const resp = http.post(url, payload, params);
    //check(resp, { 'status was 200': (r) => r.status == 200 });
    check(resp, { 'is status 400': (r) => r.status === 400 });

    //http.get('http://test.k6.io');
    //sleep(1);
}

