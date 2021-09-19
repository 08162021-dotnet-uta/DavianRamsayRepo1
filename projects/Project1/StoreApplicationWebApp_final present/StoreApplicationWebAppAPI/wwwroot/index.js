const logform = document.querySelector('#loginForm');

logform.addEventListener('submit', (e) => {
    e.preventDefault();
    const fname = logform.fname.value;
    const lname = logform.lname.value;

    fetch(`/login/${fname}/${lname}`)
        .then(res => {
            if (!res.ok) {
                console.log(`username: ${fname} password: ${lname}`);
                console.log('unable to login the user');
                throw new Error(`Network response was not ok (${res.status})`);
            }
            return res.json();
        })
        .then(res => {
            console.log(res);
            sessionStorage.setItem('user', JSON.stringify(res));
            console.log(sessionStorage.getItem('user'));
            //sessionStorage.clear();
            location.href = "locationEmpty.html";
        })
        .catch(err => console.log(`There was an error ${err}`));
});