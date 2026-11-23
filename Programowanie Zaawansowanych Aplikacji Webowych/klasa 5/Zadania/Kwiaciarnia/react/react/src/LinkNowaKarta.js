import { Link } from 'react-router-dom';

function LinkNowaKarta({ to, children, ...props }) {
  return (
    <Link {...props} to={to} target="_blank" rel="noopener noreferrer">
      {children}
    </Link>
  );
}

export default LinkNowaKarta;
