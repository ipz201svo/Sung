import React, { ReactNode } from 'react';
import Col from 'react-bootstrap/esm/Col';
import Container from 'react-bootstrap/Container';
import Navbar from 'react-bootstrap/Navbar';
import Nav from 'react-bootstrap/Nav';
import { Row } from 'react-bootstrap';

interface Props {
  children: ReactNode;
}

const Layout = ({
  children,

}: Props) => {
  return (
    <div className="bg-light">
      <Navbar className="bg-primary" /*className={styles.bg3}*/ variant="light">
        <Container className="justify-content-center lh-1">
          <Navbar.Brand href="#home">
            SUNG
          </Navbar.Brand>
        </Container>
      </Navbar>
      <Navbar bg="dark" variant="dark" className="justify-content-center lh-1">
        <Nav>
          <Nav.Link className="border-end">FEATURED</Nav.Link>
          <Nav.Link className="border-end">CHARTS</Nav.Link>
          <Nav.Link>ADD A SONG</Nav.Link>
        </Nav>
      </Navbar>
      <Container fluid className="bg-light">
        <Row className="justify-content-md-center">
          <Col md={'10'} className="py-3">
            {children}
          </Col>
        </Row>
      </Container>
    </div>
  );
};

export default Layout;