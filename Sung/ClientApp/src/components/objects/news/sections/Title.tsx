import React from 'react';

interface Props {
  children: React.ReactNode;
}

function Title({ children }: Props) {
  return (<h1 className="fs-1 text-center text-uppercase fw-bold">{children}</h1>);
}

export default Title;