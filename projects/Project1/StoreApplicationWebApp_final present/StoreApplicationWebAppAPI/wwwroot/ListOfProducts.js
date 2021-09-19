
window.onload = function () {

	fetch("Product/Details")
		.then(res => res.json())
		.then(prod => {
			console.log(prod)
			const lop = document.querySelector('.productsdiv');
			for (let x = 0; x < prod.length; x++) {
				lop.innerHTML += `<p>The product is ${prod[x].productName}.</p>`;
			}
		});
	
}