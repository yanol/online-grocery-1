import { forwardRef } from "react";
import { FaChevronDown, FaChevronUp } from "react-icons/fa";

import "./ProceedOrder.css";

const proceedOrderButton = forwardRef((props, ref) => {
  const { children, toggle, open } = props;
  // this.handleClick = this.handleClick.bind(this);

 /*  handleClick() 
  {
    this.setState({ message: 'Button clicked!' });
  };
 */
  return (
    <div>
      
    </div>
  );

  // return (
  //   <div
  //     onClick={toggle}
  //     className={`proceedorder-btn ${open ? "button-open" : null}`}
  //     ref={ref}
  //   >
  //     {children}
  //     <span className="toggle-icon">
  //       {open ? <FaChevronUp /> : <FaChevronDown />}
  //     </span>
  //   </div>
  // );
});

export default proceedOrderButton;
