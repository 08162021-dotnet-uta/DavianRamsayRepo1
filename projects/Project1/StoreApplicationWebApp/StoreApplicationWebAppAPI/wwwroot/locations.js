window.onload = function () {
    //console.log('Something');
    console.log(sessionStorage.getItem('user'));
    let user = JSON.parse(sessionStorage.getItem('user'));
    document.getElementById("place1").innerHTML = `Welcome ${user.fname} ${user.lname}!<br>Please choose you preferred location below!<br>`;
    //List the stores as buttons
    fetch("store/storelist")
        .then(res => res.json())
        .then(store => {
            console.log(store)
            const lop = document.querySelector('.stores');
            for (let x = 0; x < store.length; x++) {
                lop.innerHTML += `<p>Store Location: ${store[x].location}</p>`;
                lop.innerHTML += `<button type="button">select this store</button>`;

            }
        });
    fetch("Product/Details")
        .then(res => res.json())
        .then(prod => {
            console.log(prod)
            const lop = document.querySelector('.productsdiv');
            for (let x = 0; x < prod.length; x++) {
                lop.innerHTML += `<p>${prod[x].productName}.</p>`;
            }
        });


    //                 }
    //             });
    //    //}

    //        nction () {
    //    //     fetch("sto    orelist")
    //    //             (res => res.json())
    //    //         then(store => {
    //    //             console.log(store)
    //                  const lop = document.querySelector('.stores'    /    //             for (let x = 0; x < store.length; x++) {
    //    //                 op.innerHTML += `    e stores are: $    e[x].location}</p>`;
    //    //             }
    //    //         });
    //    // }) ();



    //    //dcument.getElementById("place1").innerHTML += `<br>Name: ${user.fname}`;

    ////}
    //        fetch("Product/productlist")
    //            .then(res => res.json())
    //            .then(product => {
    //                Console.log(product)
    //                const str = document.querySelector('.product');
    //                for (let y = 0; y < product.length; y++) {
    //                    str.innerHTML += `<p> Products${product[y].productname}</p>`;

    //                }
    //            })();
}