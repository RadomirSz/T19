import React from 'react';

function Header(props) {
  return (
    <header>
      <h1 className='tytulstrony'>Zapraszamy do obliczeń {props.typobliczen}</h1>
    </header>
  );
}

export default Header;
