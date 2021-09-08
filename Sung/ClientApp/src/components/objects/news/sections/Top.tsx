import React from 'react';
import Title from './Title';

function Top() {
  // const style = {
  //   position: 'absolute',
  //   width: '100%',
  //   transform: 'translateX(-50%)',
  //   left: '50%',
  // };
  return (
    <>
      <Title>Title</Title>
      <img
        src="https://images.unsplash.com/photo-1610875581241-200212df014f?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1950&q=80"
        // className="img-fluid"
        //style={style}
        alt="..."
      />
    </>
  );
}

export default Top;