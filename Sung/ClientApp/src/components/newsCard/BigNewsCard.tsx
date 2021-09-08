import React from 'react';
import { Card, Container, Row, Col } from 'react-bootstrap';

interface Props {
  id: string;
  title: string;
  authorId: string;
  author: string;
  publishingDate: string;
  imageUrl: string;
}

function BigNewsCard({ id, title, author, authorId, publishingDate, imageUrl }: Props) {
  return (
    <Card bg="transparent" border="light">
      <Container>
        <Row>
          <Col sm={'5'}>
            <Card.Body>
              <Card.Title className="fs-1">{title}</Card.Title>
              {/* <Card.Text>
                {subtitle}
              </Card.Text> */}
              <Card.Text>
                <small>by {author} / <span className="text-muted">{publishingDate}</span></small>
              </Card.Text>
            </Card.Body>
          </Col>
          <Col sm={'7'}>
            <Card.Img variant="bottom" src="https://images.unsplash.com/photo-1628191010210-a59de33e5941?ixid=MnwxMjA3fDF8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1950&q=80" />
          </Col>
        </Row>

      </Container>
    </Card>
  );
}

export default BigNewsCard;