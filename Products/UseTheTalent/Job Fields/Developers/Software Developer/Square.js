class Square extends React.Component {
	render() {
		return (
			<button className="square">
			{/* Something Goes Here */}
			</button>
		);
		
	}
}

class Board estends React.Component {
	renderSquare(i) {
		return <Square />
	}
	
	render() {
		
		const status = 'Next player: X';
		
		return (
			<div>
			<div className="status">{status}</div>
		)
	}
	
}