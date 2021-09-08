fetch("http://api.icndb.com/jokes/random/5%22,",)
  .then(res => res.json())
  .then(res => {
    console.log(res)
    return res;
  }).then(
    res => {
      //const body = document.querySelector('body');
      for (let i = 0; i < res.value.length; i++) {
        const ele = document.getElementById(`${i + 1}`)
        //body.innerHTML +=  `<p>${res.value[i].joke</p>}`

        ele.innerHTML = res.value[i].joke;
      }
      console.log(this.ResponseText);
    }
  )