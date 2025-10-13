import React from 'react';

function Header ( props ) {
  return (
    <header className="header">
      <div className="logo-container">
        <img src={props.companyInfo.logo} alt="Wataha Trans Logo" className="logo" />
      </div>
      <h1 className="company-title">
        Witamy na stronie firmy: {props.companyInfo.name}
      </h1>
    </header>
  );
};

export default Header;