import { forwardRef } from "react";
import { FaChevronDown, FaChevronUp } from "react-icons/fa";

import './GroceryDd.css';

const GroceryDdButton = forwardRef((props, ref) => {
  const { children, toggle, open } = props;

  return (
    <div
      onClick={toggle}
      className={`grocery-btn ${open ? "button-open" : null}`}
      ref={ref}
    >
      {children}
      <span className="toggle-icon">
        {open ? <FaChevronUp /> : <FaChevronDown />}
      </span>
    </div>
  );
});

export default GroceryDdButton;
