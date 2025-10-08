import React from 'react';

const Header = ({ companyName, slogan }) => {
  return (
    <header className="header">
      <div className="logo-container">
        <img src="/logo-wataha-trans.svg" alt="Wataha Trans Logo" className="logo" />
      </div>
      <h1 className="company-title">
        Witamy na stronie firmy: {companyName}
      </h1>
      <h2 className="subtitle">{slogan}</h2>
    </header>
  );
};

export default Header;